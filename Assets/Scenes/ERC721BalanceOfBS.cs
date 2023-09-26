using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ERC721BalanceOfBS : MonoBehaviour
{
    async void Start()
    {
     
    }

    async public void CheckNFT()
    {
        string chain = PlayerPrefs.GetString("Chain");
        string network = PlayerPrefs.GetString("Network");
        string contract = "0x2934f6e18b11eb55eA4aA7AFA3e24A6cEC95c17C";
        string account = PlayerPrefs.GetString("Account");
        string RPC = PlayerPrefs.GetString("RPC");
        //var RPC = new JsonRpcProvider("https://bsc-mainnet.core.chainstack.com/371f622c2d36ef911bcc2865a5d5756a");

        Debug.Log("CHAIN: " + chain);
        Debug.Log("NETWORK: " + network);
        Debug.Log("ACCOUNT: " + account);
        Debug.Log("CONTRACT: " + contract);
        Debug.Log("RPC: " + RPC);

        //BigInteger balanceOf = await ERC721.BalanceOf(contract, account);
        //print("NFT BALANCE: " + balanceOf);

        //if (balanceOf > 0)
        //{
        //   // SceneManager.LoadScene(2);
        //}
    }

}

