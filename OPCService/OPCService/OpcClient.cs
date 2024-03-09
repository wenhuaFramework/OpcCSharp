using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPCAutomation;

namespace OPCService
{
    class OpcClient : IDisposable
    {
        private OPCServer _opcServer;
        private readonly Dictionary<string, OPCGroup> _groups = new Dictionary<string, OPCGroup>();
        private readonly Dictionary<string, OPCItem> _items = new Dictionary<string, OPCItem>();

        public OpcClient(string serverProgId)
        {
            _opcServer = new OPCServer();
            ServerProgId = serverProgId;
        }

        public string ServerProgId { get; }

        public bool Connect()
        {
            try
            {
                _opcServer.Connect(ServerProgId, "");
                if (_opcServer.ServerState == (int)OPCServerState.OPCRunning)
                {
                    Console.WriteLine("Connected to OPC server.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Failed to connect to OPC server.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to OPC server: {ex.Message}");
                return false;
            }
        }

        public void Disconnect()
        {
            if (_opcServer != null && _opcServer.ServerState == (int)OPCServerState.OPCRunning)
            {
                _opcServer.Disconnect();
                Console.WriteLine("Disconnected from OPC server.");
            }
        }

        public bool AddGroup(string groupName)
        {
            try
            {
                OPCGroups opcGroups = _opcServer.OPCGroups;
                OPCGroup opcGroup = opcGroups.Add(groupName);
                opcGroup.IsActive = true;
                opcGroup.UpdateRate = 1000;
                opcGroup.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(OnDataChange);
                _groups.Add(groupName, opcGroup);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding group to OPC server: {ex.Message}");
                return false;
            }
        }

        public bool AddItem(string groupName, string itemName)
        {
            try
            {
                if (_groups.TryGetValue(groupName, out OPCGroup opcGroup))
                {
                    OPCItems opcItems = opcGroup.OPCItems;
                    OPCItem opcItem = opcItems.AddItem(itemName, opcItems.Count + 1); //需要一个唯一的 clientHandle 来标识每个添加的 OPCItem
                    _items.Add(itemName, opcItem);
                    return true;
                }
                else
                {
                    Console.WriteLine($"Group '{groupName}' not found.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding item to OPC group: {ex.Message}");
                return false;
            }
        }

        public object ReadItemValue(string groupName, string itemName)
        {
            try
            {
                if (_groups.TryGetValue(groupName, out OPCGroup opcGroup))
                {
                    OPCItems opcItems = opcGroup.OPCItems;
                    //opcItems.Item(itemName).Read(1, out object value, out _, out _);
                    if (_items.TryGetValue(itemName, out OPCItem opcItem))
                    {
                        opcItem.Read(1, out object value, out _, out _);
                        return value;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine($"Group '{groupName}' not found.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading item value: {ex.Message}");
                return null;
            }
        }

        public bool WriteItemValue(string groupName, string itemName, object value)
        {
            try
            {
                if (_groups.TryGetValue(groupName, out OPCGroup opcGroup))
                {
                    OPCItems opcItems = opcGroup.OPCItems;
                    //OPCItem opcItem = opcItems.Item(itemName);
                    if (_items.TryGetValue(itemName, out OPCItem opcItem))
                    {
                        opcItem.Write(value);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine($"Group '{groupName}' not found.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing value to item {itemName}: {ex.Message}");
                return false;
            }
        }

        private void OnDataChange(int transactionID, int numItems, ref Array clientHandles, ref Array itemValues, ref Array qualities, ref Array timeStamps)
        {
            Console.WriteLine("Data Change event received:");
            for (int i = 1; i <= numItems; i++)
            {
                Console.WriteLine($"Item: {clientHandles.GetValue(i)} Value: {itemValues.GetValue(i)} Quality: {qualities.GetValue(i)} Timestamp: {timeStamps.GetValue(i)}");
            }
        }

        public void Dispose()
        {
            Disconnect();
            _opcServer = null;
            _groups.Clear();
            _items.Clear();
        }
    }
}
