namespace KFDtool.P25.DeviceProtocol
{
    public interface IDeviceProtocol
    {
        void SendKeySignature();

        void InitSession();

        void CheckTargetMrConnection();

        void EndSession();

        byte[] PerformKmmTransfer(byte[] kmm);
    }
}
