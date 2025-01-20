using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackPerformer : MonoBehaviour
{
    [SerializeField] private Character character;

    [Header("UI Buttons")]
    [SerializeField] private Button attack1Button;
    [SerializeField] private Button attack2Button;
    [SerializeField] private Button attack3Button;

    private IAttackedStrategy attack1Strategy;
    private IAttackedStrategy attack2Strategy;
    private IAttackedStrategy attack3Strategy;

    private void Start()
    {
        attack1Strategy = new Attack1();
        attack2Strategy = new Attack2();
        attack3Strategy = new Attack3();

    }
}
