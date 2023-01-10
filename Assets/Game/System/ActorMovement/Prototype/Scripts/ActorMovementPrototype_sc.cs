using AutoBot.Utilities.Extensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ActorMovement.Prototype.Scripts
{
    public class ActorMovementPrototype_sc : MonoBehaviour
    {
        [SerializeField] private TMP_Text textState;
        

        [SerializeField] private Button buttonMove;

        void Start()
        {
            textState.text = "idle";
            buttonMove.BindClick(MoveToward);
        }

        private void MoveToward()
        {
            transform.position += Vector3.right;
            textState.text = "Moving";
        }
    }
}