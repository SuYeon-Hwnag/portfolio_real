using UnityEngine;

namespace Retro.ThirdPersonCharacter
{
    public class PlayerInput : MonoBehaviour
    {
        public int Hp_player_max;
        public int Hp_player_now;
        public int attack_damage;
        public bool attack = false;

        private bool _attackInput;
        private bool _specialAttackInput;
        private Vector2 _movementInput;
        private bool _jumpInput;
        private bool _changeCameraModeInput;

        public bool AttackInput {get => _attackInput;}
        public bool SpecialAttackInput {get => _specialAttackInput;}
        public Vector2 MovementInput {get => _movementInput;}
        public bool JumpInput { get => _jumpInput; }
        public bool ChangeCameraModeInput {get => _changeCameraModeInput;}

        private void Start()
        {
            Hp_player_max = 100;
            Hp_player_now = 100;
            attack_damage = 50;
        }

        private void Update()
        {
            _attackInput = Input.GetMouseButtonDown(0);
            _specialAttackInput = Input.GetMouseButtonDown(1);

            _movementInput.Set(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
            _jumpInput = Input.GetButton("Jump");
            _changeCameraModeInput = Input.GetKeyDown(KeyCode.F);
        }

        public void attack_true()
        {
            attack = true;
        }

        public void attack_false()
        {
            attack = false;
        }


    }
}