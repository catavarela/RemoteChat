namespace Solution
{
    //used by the client
    public interface IServerProxy
    {
        //sends a message to the server -> (server) sends the message to the list of clients
        void Send(string message);

        //(server) adds the client to the list of clients
        void Connect(IClientProxy client);
    }

    //used by the server
    public interface IClientProxy
    {
        //sends a message to the client -> (client) puts the message in the textbox
        void Send(string message);

    }
}
