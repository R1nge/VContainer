using UnityEngine;
using UnityEngine.UI;

namespace View
{
    public class LogView : MonoBehaviour
    {
        [SerializeField] private Button button;
        public Button GetButton() => button;
    }
}