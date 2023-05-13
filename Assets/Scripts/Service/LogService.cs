using UnityEngine;

namespace Service
{
    public sealed class LogService
    {
        public void Log(string message)
        {
            Debug.Log(message);
        }
    }
}