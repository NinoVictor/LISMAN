﻿using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using System.Data.Entity.Validation;


namespace LismanService {
    public partial class LismanService : IGameManager {
       static Dictionary<int, List<String>> listGamesOnline = new Dictionary<int,List<String>>();
        public int CreateGame(string user)
        {
            int idgame = 0;
            try
            {
                using (var dataBase = new EntityModelContainer())
                {
                    var newGame = new DataAccess.Game
                    {
                        Creation_date = DateTime.Now,
                        Status = true,
                        Members = new List<DataAccess.Account>(),
                        Last_update = DateTime.Now
                    };
                    try
                    {
                        dataBase.GameSet.Add(newGame);
                        dataBase.SaveChanges();
                    }
                    catch (DbEntityValidationException ex)
                    {
                        Logger.log.Error(ex);
                        return -1;
                    }

                    idgame = dataBase.GameSet.Max(u => u.Id);
                }
            }
            catch (Exception ex)
            {
                Logger.log.Error("Funtion CreateGame: " + ex.Message);
            }
            

            var listPlayer = new List<String>();
            listGamesOnline.Add(idgame, listPlayer);
            listGamesOnline[idgame].Add(user);
            Console.WriteLine("Game created by {0} ID:{1}, at:{2}", user, idgame, DateTime.Now);
            return idgame;
            
        }

        public int JoinGame(string user)
        {
            foreach (KeyValuePair<int, List<String>> games in listGamesOnline) {
                if(games.Value.Count < 4) {
                    games.Value.Add(user);
                    Console.WriteLine("{0} joined game ID:{1}, at:{2}",user, games.Key, DateTime.Now);
                    return games.Key;
                }
            }
            
            return -1;
        }

       public int LeaveGame(string user, int game)
        {
            int isDelete = 1; 
            var listGameUserNames = listGamesOnline[game];
            listGameUserNames.Remove(user);
            if (listGameUserNames.Count == 0) 
            {
                listGamesOnline.Remove(game);
                Console.WriteLine("Game removed ID:{0}, at:{1}", game, DateTime.Now);
            }
            else
            {
                LeaveChat(user, game);
            }
            return isDelete;
        }
    }
}
