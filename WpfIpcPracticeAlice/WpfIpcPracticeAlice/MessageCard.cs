namespace WpfIpcPracticeAlice
{
    using System;

    /// <summary>
    /// 名前と本文
    /// 
    /// プロセス間通信(IPC) によって複数のプロセスで共有します
    /// </summary>
    public class MessageCard : MarshalByRefObject
    {
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// メッセージ
        /// </summary>
        public string Message { get; private set; }
    }
}
