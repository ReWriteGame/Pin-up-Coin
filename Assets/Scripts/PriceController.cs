using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceController : MonoBehaviour
{
    [SerializeField] private PriceData data;
    [SerializeField] private Text myPrice;


    [SerializeField] private Text BTC;
    [SerializeField] private Text ETH;
    [SerializeField] private Text MONERO;
    [SerializeField] private Text RIPPLE;    
    [SerializeField] private Text DOGE;

    public void applyPrice()
    {
        data.BTC = float.Parse(BTC.text);
        data.ETH = float.Parse(ETH.text);
        data.MONERO = float.Parse(MONERO.text);
        data.RIPPLE = float.Parse(RIPPLE.text);
        data.DOGE = float.Parse(DOGE.text);
    }
    public void showPrice()
    {
        BTC.text = $"{data.BTC}";
        ETH.text = $"{data.ETH}";
        MONERO.text = $"{data.MONERO}";
        RIPPLE.text = $"{data.RIPPLE}";
        DOGE.text = $"{data.DOGE}";
    }


    public void calculateMoney()
    {
        BTC.text = $"{data.BTC * float.Parse(myPrice.text)}";
        ETH.text = $"{data.ETH * float.Parse(myPrice.text)}";
        MONERO.text = $"{data.MONERO * float.Parse(myPrice.text)}";
        RIPPLE.text = $"{data.RIPPLE * float.Parse(myPrice.text)}";
        DOGE.text = $"{data.DOGE * float.Parse(myPrice.text)}";
    }
}
