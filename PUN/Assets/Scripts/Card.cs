using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Attack AttackValue;
    public CardPlayer player;
    public Vector2 OriginalPositon;
    Vector2 OriginalScale;
    Color originalColor;

    bool isClickable = true;

    private void Start()
    {
        OriginalPositon = this.transform.position;
        OriginalScale = this.transform.localScale;
        originalColor = GetComponent<Image>().color;
    }

    public void OnClick()
    {
        if (isClickable)
            player.SetChoosenCard(this);
    }

    internal void Reset()
    {
        transform.position = OriginalPositon;
        transform.localScale = OriginalScale;
        GetComponent<Image>().color = originalColor;
    }

    public void SetClickable(bool value)
    {
        isClickable = value;
    }
}


