﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    //Built-in Unity function for handling collisions.
    //This function will be called when another object bumps into the one this script is attached to.
    void OnCollisionEnter2D(Collision2D collisionData)
    {
        //Get the objected collided with.
        Collider2D objectCollidedWith = collisionData.collider;

        //Get PlayerHealth attached to that object (if there is one).
        PlayerHealth player = objectCollidedWith.GetComponent<PlayerHealth>();

        //Check if a player health script was found on the object collided with. 
        //This if statement is true if the player variable is NOT null (not empty).
        if (player != null)
        {
            //This means there WAS a PlayerHealth script attached to the object collided with.
            //This means this object is the player.

            //Therefore perform the action.
            player.Kill();
        }
    }

}
