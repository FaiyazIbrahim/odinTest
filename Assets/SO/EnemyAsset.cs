using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;


[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObjects/EnemyData", order = 1)]
public class EnemyAsset : ScriptableObject
{
    [ProgressBar(0, 100, r: 1, g: 1, b: 1, Height = 20)]
    public int speed;


    [ProgressBar(0, 10, 0, 1, 0, Segmented = true)]
    public float health;



    [ProgressBar(0, 100, ColorGetter = "GetHealthBarColor")]
    public float attackRange = 50;

    [Range(20, 50)]
    [BoxGroup("Stacked Health"), HideLabel]
    public float runSpeed;

}
