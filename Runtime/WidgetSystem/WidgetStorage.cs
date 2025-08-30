using System.Collections.Generic;
using UnityEngine;

namespace UralHedgehog.UI
{
    [CreateAssetMenu(fileName = "WidgetStorage", menuName = "Storage/Widget", order = 0)]
    public class WidgetStorage : ScriptableObject
    {
        [SerializeField] private MonoBehaviour[] _widgets;
        public IEnumerable<MonoBehaviour> Widgets => _widgets;
    }
}