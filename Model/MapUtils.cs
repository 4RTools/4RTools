using _4RTools.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading;


namespace _4RTools.Utils
{
    public class MapModel
    {


        public string mapname { get; set; }
        public bool autopotonmap { get; set; }//disable autopot on map
        public bool autobuffonmap { get; set; }//disable autobuff on map

        public MapModel(string mapname, bool autopotonmap, bool autobuffonmap)
        {
            this.mapname = mapname;
            this.autopotonmap = autopotonmap;
            this.autobuffonmap = autobuffonmap;
        }
    }


    public class MapUtils : Action
    {
        public List<MapModel> mapsList = new List<MapModel>();

        private string ACTION_NAME = "MapChecks";

        private _4RThread thread;


        public MapUtils()
        {
        }
        public void setMapList(List<MapModel> newlist)
        {
            this.mapsList = newlist;
        }

        public void updateautopot(bool autopot)
        {
            Client c = ClientSingleton.GetClient();
            if (c != null)
            {

                string mapnamae = ClientSingleton.GetClient().ReadMapName();
                if (autopot)//true disable //false enable
                {
                    MapModel map = ProfileSingleton.GetCurrent().mapUtils.getMatchMap(mapnamae);
                    List<MapModel> maps = ProfileSingleton.GetCurrent().mapUtils.GetMapList();
                    MapModel mapclone = map;
                    mapsList.Remove(map);
                    mapclone.autopotonmap = true;
                    mapsList.Add(mapclone);
                    ProfileSingleton.GetCurrent().mapUtils.mapsList=maps;
                }
                else
                {
                    MapModel map = ProfileSingleton.GetCurrent().mapUtils.getMatchMap(mapnamae);
                    List<MapModel> maps = ProfileSingleton.GetCurrent().mapUtils.GetMapList();
                    MapModel mapclone = map;
                    mapsList.Remove(map);
                    mapclone.autopotonmap = false;
                    mapsList.Add(mapclone);
                    ProfileSingleton.GetCurrent().mapUtils.mapsList = maps;
                }
            }
        }
        public void updateautobuff(bool autobuff)
        {
            Client c=ClientSingleton.GetClient();
            if (c != null)
            {

                string mapnamae = ClientSingleton.GetClient().ReadMapName();
                if (autobuff)//true disable//false enable
                {
                    MapModel map = ProfileSingleton.GetCurrent().mapUtils.getMatchMap(mapnamae);
                    List<MapModel> maps = ProfileSingleton.GetCurrent().mapUtils.GetMapList();
                    MapModel mapclone = map;
                    mapsList.Remove(map);
                    mapclone.autobuffonmap = true;
                    mapsList.Add(mapclone);
                    ProfileSingleton.GetCurrent().mapUtils.mapsList=maps;
                }
                else
                {
                    MapModel map = ProfileSingleton.GetCurrent().mapUtils.getMatchMap(mapnamae);
                    List<MapModel> maps = ProfileSingleton.GetCurrent().mapUtils.GetMapList();
                    MapModel mapclone = map;
                    mapsList.Remove(map);
                    mapclone.autobuffonmap = false;
                    mapsList.Add(mapclone);
                    ProfileSingleton.GetCurrent().mapUtils.mapsList = maps;
                }
                
            }
        }
        public MapModel getMatchMap(string mapname)
        {
            foreach (MapModel map in ProfileSingleton.GetCurrent().mapUtils.mapsList)
            {
                if(map.mapname == mapname)
                {
                    return map;
                }
            }
            MapModel newmap = new MapModel(mapname, false, false);
            ProfileSingleton.GetCurrent().mapUtils.mapsList.Add(newmap);
            return newmap;
        }

        public List<MapModel> GetMapList()
        {
            return this.mapsList;
        }
        public void Start()
        {
            Client roClient = ClientSingleton.GetClient();
            if (roClient != null)
            {
                this.thread = new _4RThread(_ => MapThreadExecution(roClient));
                _4RThread.Start(this.thread);
            }
        }

        private int MapThreadExecution(Client roClient)
        {
            string mapname = roClient.ReadMapName();
            _ = getMatchMap(mapname);

            Thread.Sleep(5000);
            return 0;
        }


        public void Stop()
        {
            _4RThread.Stop(this.thread);
        }

        public string GetConfiguration()
        {
            return JsonConvert.SerializeObject(this);
        }

        public string GetActionName()
        {
            return this.ACTION_NAME;
        }

    }



    }

