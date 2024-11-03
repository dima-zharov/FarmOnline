using UnityEngine;
using UnityEngine.Android;

public class MicroPermisiion
{
    public bool IsPermissionForMicro() => (Permission.HasUserAuthorizedPermission(Permission.Microphone) || SystemInfo.deviceType == DeviceType.Desktop);

}
