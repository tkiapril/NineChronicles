using System;
using System.Collections;
using System.Collections.Generic;
using Nekoyume.UI.Module.WorldBoss;
using UnityEngine;

namespace Nekoyume
{
    [CreateAssetMenu(fileName = "UI_WorldBossData", menuName = "Scriptable Object/World Boss Data",
        order = int.MaxValue)]
    public class WorldBossScriptableObject : ScriptableObject
    {
        public List<MonsterData> Monsters;

        public List<GradeData> Grades;

        [Serializable]
        public class GradeData
        {
            public WorldBossGrade grade;
            public Sprite icon;
        }

        [Serializable]
        public class MonsterData
        {
            public int id;
            public GameObject prefab;
        }
    }
}
