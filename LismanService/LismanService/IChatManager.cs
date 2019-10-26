﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace LismanService {
    [ServiceContract(CallbackContract = typeof(IChatManagerCallBack))]
    public interface IChatManager {
        [OperationContract(IsOneWay = true)]
        void SendMessage(Message message, int Game);
        [OperationContract(IsOneWay = true)]
        void JoinChat(String user, int idgame);
        [OperationContract(IsOneWay = true)]
        void LeaveChat(String user, int idgame);
        [OperationContract(IsOneWay = true)]
        void StartGame(String user, int idgame);
    }

    [ServiceContract]
    public interface IChatManagerCallBack {
        [OperationContract(IsOneWay = true)]
        void NotifyMessage(Message message);
        [OperationContract(IsOneWay = true)]
        void NotifyJoinedPlayer(String user);
        [OperationContract(IsOneWay = true)]
        void NotifyNumberPlayers(int numberPlayers);
        [OperationContract(IsOneWay = true)]
        void NotifyLeftPlayer(String user);
        [OperationContract(IsOneWay = true)]
        void InitGame();
    }

    [DataContract]
    public partial class Message {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public System.DateTime Creation_date { get; set; }
        
        [DataMember]
        public virtual Account Account { get; set; }
    }
}
