using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TurnSystemUI : MonoBehaviour
{
    [SerializeField] private Button endTurnButton;
    [SerializeField] private TextMeshProUGUI turnNumberText;

    private void Start()
    {
        endTurnButton.onClick.AddListener(() =>
        {
            TurnSystem.Instance.NextTurn();
        });
        TurnSystem.Instance.OnTurnChanged += TurnSystem_OnTurnChanged;
        UpdateTurnText();
    }

    private void TurnSystem_OnTurnChanged(object sender, EventArgs e)
    {

    }

    private void UpdateTurnText()
    {
        turnNumberText.text = "Turn " + TurnSystem.Instance.GetTurnNumber();
    }

}
