using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class ERC721BalanceOfExample : MonoBehaviour
{
    async void Start()
    {
        string chain = "Binance";
        string network = "Mainnet";
        string contract = "0x2934f6e18b11eb55eA4aA7AFA3e24A6cEC95c17C";
        string account = PlayerPrefs.GetString("Account");

        int balance = await ERC721.BalanceOf(chain, network, contract, account);
        print(balance);
    }

    async public void CheckNFT()
    {
        string chain = "Binance";
        string network = "Mainnet";
        string contract = "0x2934f6e18b11eb55eA4aA7AFA3e24A6cEC95c17C";
        string account = PlayerPrefs.GetString("Account");
        string RPC = PlayerPrefs.GetString("RPC");

        Debug.Log("CHAIN: " + chain);
        Debug.Log("NETWORK: " + network);
        Debug.Log("ACCOUNT: " + account);
        Debug.Log("CONTRACT: " + contract);
        Debug.Log("RPC: " + RPC);

        //BigInteger balanceOf = await ERC721.BalanceOf(contract, account);
        int balance = await ERC721.BalanceOf(chain, network, contract, account);
        print("NFT BALANCE: " + balance);

        if (balance > 0)
        {
            // SceneManager.LoadScene(2);
        }
    }
}
