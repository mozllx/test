using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class Users : MonoBehaviour
{

    public string userName;
    public string userSurname;
    public string userEmail;
    public string username;
    public string password;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Users()
    {
        userName = AuthManager.uName;
        userSurname = AuthManager.uSurname;
        userEmail = AuthManager.uEmail;
        username = AuthManager.username;
        password = AuthManager.password;
    }
}
