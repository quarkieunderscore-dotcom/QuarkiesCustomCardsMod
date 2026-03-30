using UnboundLib;
using UnityEngine;

namespace QuarkiesCards.MonoBehaviours
{
    public class Up : MonoBehaviour
    {
        private MoveTransform mt;
        void start()
        {
            this.mt = this.GetComponentInParent<MoveTransform>();
        }
        void update()
        {
            if (this.mt != null)
            {
                mt.transform.AddYPosition(1f);
            }
        }
    }
}