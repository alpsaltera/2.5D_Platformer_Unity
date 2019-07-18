﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace roundbeargames_tutorial
{
    [CreateAssetMenu(fileName = "New State", menuName = "Roundbeargames/AbilityData/UpdateBoxCollider")]
    public class UpdateBoxCollider : StateData
    {
        public Vector3 TargetSize;
        public float SizeUpdateSpeed;

        public Vector3 TargetCenter;
        public float CenterUpdateSpeed;

        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            CharacterControl control = characterState.GetCharacterControl(animator);
            control.animationProgress.UpdatingBoxCollider = true;

            control.animationProgress.TargeSize = TargetSize;
            control.animationProgress.Size_Speed = SizeUpdateSpeed;

            control.animationProgress.TargetCenter = TargetCenter;
            control.animationProgress.Center_Speed = CenterUpdateSpeed;
        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {

        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo)
        {
            CharacterControl control = characterState.GetCharacterControl(animator);
            control.animationProgress.UpdatingBoxCollider = false;
        }
    }
}