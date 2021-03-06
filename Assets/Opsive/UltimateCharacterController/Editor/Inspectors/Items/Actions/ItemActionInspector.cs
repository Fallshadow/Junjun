/// ---------------------------------------------
/// Ultimate Character Controller
/// Copyright (c) Opsive. All Rights Reserved.
/// https://www.opsive.com
/// ---------------------------------------------

namespace Opsive.UltimateCharacterController.Editor.Inspectors.Items.Actions
{
    using Opsive.Shared.Editor.Inspectors.StateSystem;
    using Opsive.UltimateCharacterController.Items.Actions;
    using System;
    using UnityEditor;

    /// <summary>
    /// Shows a custom inspector for the ItemAction component.
    /// </summary>
    [CustomEditor(typeof(ItemAction))]
    public abstract class ItemActionInspector : StateBehaviorInspector
    {
        /// <summary>
        /// Returns the actions to draw before the State list is drawn.
        /// </summary>
        /// <returns>The actions to draw before the State list is drawn.</returns>
        protected override Action GetDrawCallback()
        {
            var baseCallback = base.GetDrawCallback();

            baseCallback += () =>
            {
                EditorGUILayout.PropertyField(PropertyFromName("m_ID"));
            };

            return baseCallback;
        }
    }
}