using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Web3Unity.Scripts.Library.ETHEREUEM.EIP;

public class ERC721BalanceOfBS : MonoBehaviour
{
    async void Start()
    {
        //string contract = "0x9123541E259125657F03D7AD2A7D1a8Ec79375BA";
        //string account = "0xd25b827D92b0fd656A1c829933e9b0b836d5C3e2";

        //BigInteger balance = await ERC721.BalanceOf(contract, account);
        //print(balance);
    }

    //public GameObject FlappyDorado;

    async public void CheckNFT()
    {
        string chain = PlayerPrefs.GetString("Chain");
        string network = PlayerPrefs.GetString("Network");
        //string contract = "0x44Be0B140bA103Cc5254668154fE52E189BB2d83";
        string contract = "0x2934f6e18b11eb55eA4aA7AFA3e24A6cEC95c17C";
        string account = PlayerPrefs.GetString("Account");
       // string tokenId = "1731";
        string RPC = PlayerPrefs.GetString("RPC");

        Debug.Log("CHAIN: " + chain);
        Debug.Log("NETWORK: " + network);
        Debug.Log("ACCOUNT: " + account);
        Debug.Log("CONTRACT: " + contract);
       // Debug.Log("TOKEN ID: " + tokenId);
        Debug.Log("RPC: " + RPC);

        //BigInteger balance = await ERC721.BalanceOf(contract, account);
        BigInteger balanceOf = await ERC721.BalanceOf(contract, account);
        print("NFT BALANCE: " + balanceOf);

        if (balanceOf > 0)
        {
           // SceneManager.LoadScene(2);
        }
    }

}

