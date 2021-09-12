namespace WpfIpcPracticeAlice
{
    using System;
    using System.Reflection;
    using System.Runtime.Remoting;
    // using System.Runtime.Remoting.Channels;
    // using System.Runtime.Remoting.Channels.Ipc;
    using System.Threading;

    /// <summary>
    /// プロジェクトの参照設定に [System.Runtime.Remoting] を追加してください
    /// </summary>
    public static class Utility
    {
        // IpcRemoteObject に複数のプロセスで共有するアイテムを格納
        public static void Send(object item)
        {
            string channelName = "HappyChannel";
            string itemName = "AliceCard";

            // IPC (プロセス間通信) クライアント チャンネルの生成
            // var channel = new IpcClientChannel();

            // チャンネルを登録
            // ChannelServices.RegisterChannel(channel, true);

            // リモートオブジェクトを取得
            // var remoteObject = Activator.GetObject(typeof(MessageCard), $"ipc://{channelName}/{itemName}") as MessageCard;
            // if (remoteObject != null)
            //    remoteObject.Item = item;
        }
    }
}
