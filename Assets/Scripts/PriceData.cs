using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PriceData", menuName = "ScriptableObjects/PriceData")]
public class PriceData : ScriptableObject
{
    public float BTC;
    public float ETH;
    public float MONERO;
    public float RIPPLE;
    public float DOGE;
}
