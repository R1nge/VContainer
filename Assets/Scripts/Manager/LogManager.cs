using Service;
using VContainer.Unity;
using View;

namespace Manager
{
    public class LogManager : IStartable
    {
        private readonly LogService _logService;
        private readonly LogView _logView;

        public LogManager(LogService logService, LogView logView)
        {
            _logService = logService;
            _logView = logView;
        }

        public void Start()
        {
            _logView.GetButton().onClick.AddListener(() => _logService.Log("Hello World"));
        }
    }
}