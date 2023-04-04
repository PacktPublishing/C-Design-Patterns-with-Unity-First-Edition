using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text EnemyUI;
    public List<Enemy> Enemies = new List<Enemy>();

    void Update()
    {
        EnemyUI.text = $"#1: {Enemies[0].name}\n\n" +
            $"#2: {Enemies[1].name}\n\n" +
            $"#3: {Enemies[2].name}";
    }
}