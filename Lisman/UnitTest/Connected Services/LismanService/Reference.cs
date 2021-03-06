﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTest.LismanService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LismanService.IAccountManager")]
    public interface IAccountManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountManager/AddAccount", ReplyAction="http://tempuri.org/IAccountManager/AddAccountResponse")]
        int AddAccount(Lisman.LismanService.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountManager/AddAccount", ReplyAction="http://tempuri.org/IAccountManager/AddAccountResponse")]
        System.Threading.Tasks.Task<int> AddAccountAsync(Lisman.LismanService.Account account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountManager/GetAccounts", ReplyAction="http://tempuri.org/IAccountManager/GetAccountsResponse")]
        Lisman.LismanService.Account[] GetAccounts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountManager/GetAccounts", ReplyAction="http://tempuri.org/IAccountManager/GetAccountsResponse")]
        System.Threading.Tasks.Task<Lisman.LismanService.Account[]> GetAccountsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountManager/GetAccountById", ReplyAction="http://tempuri.org/IAccountManager/GetAccountByIdResponse")]
        Lisman.LismanService.Account GetAccountById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountManager/GetAccountById", ReplyAction="http://tempuri.org/IAccountManager/GetAccountByIdResponse")]
        System.Threading.Tasks.Task<Lisman.LismanService.Account> GetAccountByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountManager/GetRecords", ReplyAction="http://tempuri.org/IAccountManager/GetRecordsResponse")]
        Lisman.LismanService.Record[] GetRecords();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountManager/GetRecords", ReplyAction="http://tempuri.org/IAccountManager/GetRecordsResponse")]
        System.Threading.Tasks.Task<Lisman.LismanService.Record[]> GetRecordsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountManagerChannel : UnitTest.LismanService.IAccountManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountManagerClient : System.ServiceModel.ClientBase<UnitTest.LismanService.IAccountManager>, UnitTest.LismanService.IAccountManager {
        
        public AccountManagerClient() {
        }
        
        public AccountManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddAccount(Lisman.LismanService.Account account) {
            return base.Channel.AddAccount(account);
        }
        
        public System.Threading.Tasks.Task<int> AddAccountAsync(Lisman.LismanService.Account account) {
            return base.Channel.AddAccountAsync(account);
        }
        
        public Lisman.LismanService.Account[] GetAccounts() {
            return base.Channel.GetAccounts();
        }
        
        public System.Threading.Tasks.Task<Lisman.LismanService.Account[]> GetAccountsAsync() {
            return base.Channel.GetAccountsAsync();
        }
        
        public Lisman.LismanService.Account GetAccountById(int id) {
            return base.Channel.GetAccountById(id);
        }
        
        public System.Threading.Tasks.Task<Lisman.LismanService.Account> GetAccountByIdAsync(int id) {
            return base.Channel.GetAccountByIdAsync(id);
        }
        
        public Lisman.LismanService.Record[] GetRecords() {
            return base.Channel.GetRecords();
        }
        
        public System.Threading.Tasks.Task<Lisman.LismanService.Record[]> GetRecordsAsync() {
            return base.Channel.GetRecordsAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LismanService.IGameManager")]
    public interface IGameManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameManager/CreateGame", ReplyAction="http://tempuri.org/IGameManager/CreateGameResponse")]
        int CreateGame(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameManager/CreateGame", ReplyAction="http://tempuri.org/IGameManager/CreateGameResponse")]
        System.Threading.Tasks.Task<int> CreateGameAsync(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameManager/JoinGame", ReplyAction="http://tempuri.org/IGameManager/JoinGameResponse")]
        int JoinGame(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameManager/JoinGame", ReplyAction="http://tempuri.org/IGameManager/JoinGameResponse")]
        System.Threading.Tasks.Task<int> JoinGameAsync(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameManager/LeaveGame", ReplyAction="http://tempuri.org/IGameManager/LeaveGameResponse")]
        int LeaveGame(string user, int game);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameManager/LeaveGame", ReplyAction="http://tempuri.org/IGameManager/LeaveGameResponse")]
        System.Threading.Tasks.Task<int> LeaveGameAsync(string user, int game);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameManagerChannel : UnitTest.LismanService.IGameManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GameManagerClient : System.ServiceModel.ClientBase<UnitTest.LismanService.IGameManager>, UnitTest.LismanService.IGameManager {
        
        public GameManagerClient() {
        }
        
        public GameManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GameManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int CreateGame(string user) {
            return base.Channel.CreateGame(user);
        }
        
        public System.Threading.Tasks.Task<int> CreateGameAsync(string user) {
            return base.Channel.CreateGameAsync(user);
        }
        
        public int JoinGame(string user) {
            return base.Channel.JoinGame(user);
        }
        
        public System.Threading.Tasks.Task<int> JoinGameAsync(string user) {
            return base.Channel.JoinGameAsync(user);
        }
        
        public int LeaveGame(string user, int game) {
            return base.Channel.LeaveGame(user, game);
        }
        
        public System.Threading.Tasks.Task<int> LeaveGameAsync(string user, int game) {
            return base.Channel.LeaveGameAsync(user, game);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LismanService.IChatManager", CallbackContract=typeof(UnitTest.LismanService.IChatManagerCallback))]
    public interface IChatManager {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatManager/SendMessage")]
        void SendMessage(Lisman.LismanService.Message message, int Game);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatManager/SendMessage")]
        System.Threading.Tasks.Task SendMessageAsync(Lisman.LismanService.Message message, int Game);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatManager/JoinChat")]
        void JoinChat(string user, int idgame);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatManager/JoinChat")]
        System.Threading.Tasks.Task JoinChatAsync(string user, int idgame);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatManager/LeaveChat")]
        void LeaveChat(string user, int idgame);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatManager/LeaveChat")]
        System.Threading.Tasks.Task LeaveChatAsync(string user, int idgame);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatManager/StartGame")]
        void StartGame(string user, int idgame);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatManager/StartGame")]
        System.Threading.Tasks.Task StartGameAsync(string user, int idgame);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatManagerCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatManager/NotifyMessage")]
        void NotifyMessage(Lisman.LismanService.Message message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatManager/NotifyJoinedPlayer")]
        void NotifyJoinedPlayer(string user);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatManager/NotifyNumberPlayers")]
        void NotifyNumberPlayers(int numberPlayers);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatManager/NotifyLeftPlayer")]
        void NotifyLeftPlayer(string user);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IChatManager/InitGame")]
        void InitGame();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatManagerChannel : UnitTest.LismanService.IChatManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChatManagerClient : System.ServiceModel.DuplexClientBase<UnitTest.LismanService.IChatManager>, UnitTest.LismanService.IChatManager {
        
        public ChatManagerClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ChatManagerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ChatManagerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatManagerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatManagerClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void SendMessage(Lisman.LismanService.Message message, int Game) {
            base.Channel.SendMessage(message, Game);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(Lisman.LismanService.Message message, int Game) {
            return base.Channel.SendMessageAsync(message, Game);
        }
        
        public void JoinChat(string user, int idgame) {
            base.Channel.JoinChat(user, idgame);
        }
        
        public System.Threading.Tasks.Task JoinChatAsync(string user, int idgame) {
            return base.Channel.JoinChatAsync(user, idgame);
        }
        
        public void LeaveChat(string user, int idgame) {
            base.Channel.LeaveChat(user, idgame);
        }
        
        public System.Threading.Tasks.Task LeaveChatAsync(string user, int idgame) {
            return base.Channel.LeaveChatAsync(user, idgame);
        }
        
        public void StartGame(string user, int idgame) {
            base.Channel.StartGame(user, idgame);
        }
        
        public System.Threading.Tasks.Task StartGameAsync(string user, int idgame) {
            return base.Channel.StartGameAsync(user, idgame);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LismanService.ILoginManager")]
    public interface ILoginManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginManager/LoginAccount", ReplyAction="http://tempuri.org/ILoginManager/LoginAccountResponse")]
        Lisman.LismanService.Account LoginAccount(string user, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginManager/LoginAccount", ReplyAction="http://tempuri.org/ILoginManager/LoginAccountResponse")]
        System.Threading.Tasks.Task<Lisman.LismanService.Account> LoginAccountAsync(string user, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginManager/LogoutAccount", ReplyAction="http://tempuri.org/ILoginManager/LogoutAccountResponse")]
        int LogoutAccount(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginManager/LogoutAccount", ReplyAction="http://tempuri.org/ILoginManager/LogoutAccountResponse")]
        System.Threading.Tasks.Task<int> LogoutAccountAsync(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginManager/UserNameExists", ReplyAction="http://tempuri.org/ILoginManager/UserNameExistsResponse")]
        bool UserNameExists(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginManager/UserNameExists", ReplyAction="http://tempuri.org/ILoginManager/UserNameExistsResponse")]
        System.Threading.Tasks.Task<bool> UserNameExistsAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginManager/EmailExists", ReplyAction="http://tempuri.org/ILoginManager/EmailExistsResponse")]
        bool EmailExists(string emailAdress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginManager/EmailExists", ReplyAction="http://tempuri.org/ILoginManager/EmailExistsResponse")]
        System.Threading.Tasks.Task<bool> EmailExistsAsync(string emailAdress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginManager/UserInSession", ReplyAction="http://tempuri.org/ILoginManager/UserInSessionResponse")]
        bool UserInSession(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginManager/UserInSession", ReplyAction="http://tempuri.org/ILoginManager/UserInSessionResponse")]
        System.Threading.Tasks.Task<bool> UserInSessionAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoginManagerChannel : UnitTest.LismanService.ILoginManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginManagerClient : System.ServiceModel.ClientBase<UnitTest.LismanService.ILoginManager>, UnitTest.LismanService.ILoginManager {
        
        public LoginManagerClient() {
        }
        
        public LoginManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Lisman.LismanService.Account LoginAccount(string user, string password) {
            return base.Channel.LoginAccount(user, password);
        }
        
        public System.Threading.Tasks.Task<Lisman.LismanService.Account> LoginAccountAsync(string user, string password) {
            return base.Channel.LoginAccountAsync(user, password);
        }
        
        public int LogoutAccount(string user) {
            return base.Channel.LogoutAccount(user);
        }
        
        public System.Threading.Tasks.Task<int> LogoutAccountAsync(string user) {
            return base.Channel.LogoutAccountAsync(user);
        }
        
        public bool UserNameExists(string username) {
            return base.Channel.UserNameExists(username);
        }
        
        public System.Threading.Tasks.Task<bool> UserNameExistsAsync(string username) {
            return base.Channel.UserNameExistsAsync(username);
        }
        
        public bool EmailExists(string emailAdress) {
            return base.Channel.EmailExists(emailAdress);
        }
        
        public System.Threading.Tasks.Task<bool> EmailExistsAsync(string emailAdress) {
            return base.Channel.EmailExistsAsync(emailAdress);
        }
        
        public bool UserInSession(string username) {
            return base.Channel.UserInSession(username);
        }
        
        public System.Threading.Tasks.Task<bool> UserInSessionAsync(string username) {
            return base.Channel.UserInSessionAsync(username);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LismanService.IMultiplayerManager", CallbackContract=typeof(UnitTest.LismanService.IMultiplayerManagerCallback))]
    public interface IMultiplayerManager {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/JoinMultiplayerGame")]
        void JoinMultiplayerGame(string user, int idGame);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/JoinMultiplayerGame")]
        System.Threading.Tasks.Task JoinMultiplayerGameAsync(string user, int idGame);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/MoveLisman")]
        void MoveLisman(Lisman.LismanService.LismanMovement movement);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/MoveLisman")]
        System.Threading.Tasks.Task MoveLismanAsync(Lisman.LismanService.LismanMovement movement);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/RemovePower")]
        void RemovePower(string user);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/RemovePower")]
        System.Threading.Tasks.Task RemovePowerAsync(string user);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/ExitGame")]
        void ExitGame(int idGame, int colorLisman, int positionX, int positionY);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/ExitGame")]
        System.Threading.Tasks.Task ExitGameAsync(int idGame, int colorLisman, int positionX, int positionY);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/Reconntection")]
        void Reconntection(string userLisman);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/Reconntection")]
        System.Threading.Tasks.Task ReconntectionAsync(string userLisman);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMultiplayerManagerCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/PrintInformationPlayers")]
        void PrintInformationPlayers(System.Collections.Generic.Dictionary<int, Lisman.LismanService.InformationPlayer> listPlayers);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/NotifyColorPlayer")]
        void NotifyColorPlayer(int colorPlayer, string user);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/NotifyLismanMoved")]
        void NotifyLismanMoved(int colorPlayer, int positionX, int positionY, string goTo);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/NotifyDisappearedPowerPill")]
        void NotifyDisappearedPowerPill(int positionX, int positionY);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/NotifyUpdateScore")]
        void NotifyUpdateScore(int colorPlayer, int scorePlayer);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/NotifyUpdateLifes")]
        void NotifyUpdateLifes(int colorPlayer, int lifePlayer);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/NotifyPlayerIsDead")]
        void NotifyPlayerIsDead(int colorPlayer);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/ReturnLismanToInitialPosition")]
        void ReturnLismanToInitialPosition(int colorPlayer, int positionX, int positionY);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/UpdateLismanSpeed")]
        void UpdateLismanSpeed(int speed, bool hasPower);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/NotifyEndGame")]
        void NotifyEndGame(int colorLisman);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMultiplayerManager/NotifyLismanLeaveGame")]
        void NotifyLismanLeaveGame(int colorGame);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMultiplayerManagerChannel : UnitTest.LismanService.IMultiplayerManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MultiplayerManagerClient : System.ServiceModel.DuplexClientBase<UnitTest.LismanService.IMultiplayerManager>, UnitTest.LismanService.IMultiplayerManager {
        
        public MultiplayerManagerClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public MultiplayerManagerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public MultiplayerManagerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MultiplayerManagerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MultiplayerManagerClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void JoinMultiplayerGame(string user, int idGame) {
            base.Channel.JoinMultiplayerGame(user, idGame);
        }
        
        public System.Threading.Tasks.Task JoinMultiplayerGameAsync(string user, int idGame) {
            return base.Channel.JoinMultiplayerGameAsync(user, idGame);
        }
        
        public void MoveLisman(Lisman.LismanService.LismanMovement movement) {
            base.Channel.MoveLisman(movement);
        }
        
        public System.Threading.Tasks.Task MoveLismanAsync(Lisman.LismanService.LismanMovement movement) {
            return base.Channel.MoveLismanAsync(movement);
        }
        
        public void RemovePower(string user) {
            base.Channel.RemovePower(user);
        }
        
        public System.Threading.Tasks.Task RemovePowerAsync(string user) {
            return base.Channel.RemovePowerAsync(user);
        }
        
        public void ExitGame(int idGame, int colorLisman, int positionX, int positionY) {
            base.Channel.ExitGame(idGame, colorLisman, positionX, positionY);
        }
        
        public System.Threading.Tasks.Task ExitGameAsync(int idGame, int colorLisman, int positionX, int positionY) {
            return base.Channel.ExitGameAsync(idGame, colorLisman, positionX, positionY);
        }
        
        public void Reconntection(string userLisman) {
            base.Channel.Reconntection(userLisman);
        }
        
        public System.Threading.Tasks.Task ReconntectionAsync(string userLisman) {
            return base.Channel.ReconntectionAsync(userLisman);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LismanService.IHeartBeat", CallbackContract=typeof(UnitTest.LismanService.IHeartBeatCallback))]
    public interface IHeartBeat {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IHeartBeat/NewLogin")]
        void NewLogin(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IHeartBeat/NewLogin")]
        System.Threading.Tasks.Task NewLoginAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IHeartBeat/ImLive")]
        void ImLive(string usernam);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IHeartBeat/ImLive")]
        System.Threading.Tasks.Task ImLiveAsync(string usernam);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHeartBeatCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IHeartBeat/NotifyOk")]
        void NotifyOk();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHeartBeatChannel : UnitTest.LismanService.IHeartBeat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HeartBeatClient : System.ServiceModel.DuplexClientBase<UnitTest.LismanService.IHeartBeat>, UnitTest.LismanService.IHeartBeat {
        
        public HeartBeatClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public HeartBeatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public HeartBeatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public HeartBeatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public HeartBeatClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void NewLogin(string username) {
            base.Channel.NewLogin(username);
        }
        
        public System.Threading.Tasks.Task NewLoginAsync(string username) {
            return base.Channel.NewLoginAsync(username);
        }
        
        public void ImLive(string usernam) {
            base.Channel.ImLive(usernam);
        }
        
        public System.Threading.Tasks.Task ImLiveAsync(string usernam) {
            return base.Channel.ImLiveAsync(usernam);
        }
    }
}
