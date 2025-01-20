using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private IAttackedStrategy currentAttackedStrategy;

    public void SetStrategy(IAttackedStrategy strategy)
    {
        currentAttackedStrategy = strategy;
    }

    public void PerformAttack()
    {
        if (currentAttackedStrategy! = null)
        {
            currentAttackedStrategy.PerformAttack();
        }
        else
        {
            Debug.LogWarning("Attack strategy nit set");
        }
    }
}
