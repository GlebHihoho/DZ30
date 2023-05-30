using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Mechanics;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] public EnemyDeathCount enemyDeathCount;
    private TextMeshProUGUI _text;

    private void Start() {
        _text = this.gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        _text.text = enemyDeathCount.GetCount().ToString();
    }
}
