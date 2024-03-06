using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitaniumAS.Opc.Client.Common;
using TitaniumAS.Opc.Client.Da;
using TitaniumAS.Opc.Client.Da.Browsing;
using System.Threading;
using System.IO;
using MongoDB.Bson;

namespace OPCClient2
{
    class Program
    {
        public static int count = 0;
        static void Main(string[] args)
        {
            // Make an URL of OPC DA server using builder.
            Uri url = UrlBuilder.Build("Matrikon.OPC.Simulation.1");
            using (var server = new OpcDaServer(url))
            {
                // Connect to the server first.
                server.Connect();

                //Create a browser and browse all elements recursively.
                var browser = new OpcDaBrowserAuto(server);

                //获取tag并保存到文件
                //BrowseChildren(browser);
                //List<string> ids = GetItemsIds(browser);
                // writeItemsIdToTxt(ids);

                //从文件中读取tag，然后读取值
                List<string> ids = readItemsIdFromTxt();
                getValues(server, ids);
            }
        }
        
        static void BrowseChildren(IOpcDaBrowser browser, string itemId = null, int indent = 0)
        {
            // When itemId is null, root elements will be browsed.
            OpcDaBrowseElement[] elements = browser.GetElements(itemId);

            // Output elements.
            foreach (OpcDaBrowseElement element in elements)
            {
                // Output the element.
                Console.Write(new String(' ', indent));
                Console.WriteLine(element);

                // Skip elements without children.
                if (!element.HasChildren)
                    continue;

                // Output children of the element.
                BrowseChildren(browser, element.ItemId, indent + 2);
            }
        }
        
        //获取所有3级itemsId
        static List<string> GetItemsIds(IOpcDaBrowser browser, string itemId = null)
        {
            List<string> catalogues1 = new List<string>();
            List<string> catalogues2 = new List<string>();
            List<string> ids = new List<string>();

            OpcDaBrowseElement[] elements = browser.GetElements(itemId);

            foreach (OpcDaBrowseElement element in elements)
            {
                if (element.IsItem == true)
                {
                    ids.Add(element.ItemId);
                    count++;
                    Console.WriteLine("已添加Item：" + element.ItemId + "  " + count.ToString());
                }

                catalogues1.Add(element.ItemId);
                Console.WriteLine("已添加1级目录：" + element.ItemId + "  ");
            }

            foreach (string catalogue in catalogues1)
            {
                elements = browser.GetElements(catalogue);
                foreach (OpcDaBrowseElement element in elements)
                {
                    if (element.IsItem == true)
                    {
                        ids.Add(element.ItemId);
                        count++;
                        Console.WriteLine("已添加Item：" + element.ItemId + "  " + count.ToString());
                    }
                    catalogues2.Add(element.ItemId);
                    Console.WriteLine("已添加2级目录：" + element.ItemId + "  ");
                }
            }

            foreach (string catalogue in catalogues2)
            {
                elements = browser.GetElements(catalogue);
                foreach (OpcDaBrowseElement element in elements)
                {
                    if (element.IsItem == true)
                    {
                        ids.Add(element.ItemId);
                        count++;
                        Console.WriteLine("已添加Item：" + element.ItemId + "  " + count.ToString());
                    }
                }
            }
            return ids;
        }
        
        //输出为txt文档
        static void writeItemsIdToTxt(List<string> ids)
        {
            FileStream fs = new FileStream(@"Itemsid.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(fs, Encoding.Default);
            foreach(string id in ids)
            {
                writer.WriteLine(id);
                Console.WriteLine("写入" + id);
            }
            Console.WriteLine("完成"+ writer);
            writer.Close();
            fs.Close();
            Console.ReadKey();
        }
        
        //读取txt文档
        static List<string> readItemsIdFromTxt()
        {
            List<string> ids = new List<string>();
            int i = 0;

            FileStream fs = new FileStream(@"Itemsid.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs, Encoding.Default);

            string id = reader.ReadLine();
            while(id != null)
            {
                i++;
                ids.Add(id);
                Console.WriteLine(i.ToString() + ". 读取 " + id );
                id = reader.ReadLine();
            }
            Console.WriteLine("完成");
            reader.Close();
            fs.Close();
            return ids;
        }
        
        //获取value并插入mangodb数据库
        static void getValues(OpcDaServer server, List<string> ids)
        {
            List<OpcDaItemDefinition> items = new List<OpcDaItemDefinition>();
            foreach (string id in ids)
            {
                var definition1 = new OpcDaItemDefinition
                {
                    ItemId = id,
                    IsActive = true
                };
                items.Add(definition1);
                Console.WriteLine("items " + id);
            }

            OpcDaGroup group = server.AddGroup("MyGroup");
            group.IsActive = true;

            //OpcDaItemDefinition[] items = AddItems();
            OpcDaItemResult[] results = group.AddItems(items);
            string database = "mongodb://localhost:27017/opc";
            MongoDbHelper mongoDbHelper = new MongoDbHelper(database);
            var db = mongoDbHelper.GetDb(database);
            string collName = "tags";

            foreach (OpcDaItemResult result in results)
            {
                if (result.Error.Failed)
                    Console.WriteLine("Error adding items: {0}", result.Error);
            }

            OpcDaItemValue[] values = group.Read(group.Items, OpcDaDataSource.Device);
            int i;
            for (i = 0; i < group.Items.Count; i++)
            {
                Item item1 = new Item
                {
                    tag_name = values[i].Item.ItemId,
                    description = "",
                    value = Convert.ToString(values[i].Value),
                    datetime = DateTime.Now.ToString("yyyy-MM-dd HH:"+(int.Parse(DateTime.Now.ToString("mm")) - (int.Parse(DateTime.Now.ToString("mm")) % 5)).ToString() + ":00")
                };
                BsonDocument document = item1.ToBsonDocument();
                var result = mongoDbHelper.Insert(collName, document);
                Console.WriteLine($"【插入】>>>【{result.iFlg}】>>>{DateTime.Now}");
                //Console.WriteLine(values[i].Item.ItemId + " value is {0}", Convert.ToString(values[i].Value));
            }
            Console.WriteLine("total: " + i);
        }
    }
}
