using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    [System.Serializable]
    public class State {
        public Color fillColor;
        public Color outlineColor;
    }
    private TextMeshProUGUI text;
    private Image fill;
    private Outline outline;

    public State state { get; private set; }
    public char letter {  get; private set; }
    private void Awake() {
        text = GetComponentInChildren<TextMeshProUGUI>();
        fill = GetComponentInChildren<Image>();
        outline = GetComponentInChildren<Outline>();
    }

    public void SetLetter(char letter) {
        this.letter = letter;
        text.text = letter.ToString();
    }

    public void SetState(State state) {
        this.state = state;
        fill.color = state.fillColor;
        outline.effectColor = state.outlineColor;
    }
}
