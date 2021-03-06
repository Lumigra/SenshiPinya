﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountFriend : MonoBehaviour
{
    [SerializeField] private FriendFound friendFound;

    private void Start()
    {
        friendFound = FindObjectOfType<FriendFound>();
    }

    public void CountFriends()
    {
        // Counts a friend if found by player
        friendFound.friendsFound++;

        gameObject.SetActive(false);
        //gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
}
