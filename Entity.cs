using System;
using System.Collections.Generic;
using Godot;

namespace RedLamp_Entity
{
    public class Entity
    {
        uint id;
        String type;
        String UserName;
        String Mobtype;
        uint Entitytype;
        Vector3 position = Vector3.Zero;
        Vector3 velocity = Vector3.Zero;
        float yaw = 0;
        float pitch = 0;
        bool onGround= true;
        float height= 0;
        float width= 0;
        Dictionary<int, String> effects;
        // 0 = held item, 1-4 = armor slot
        String[] equipment = new String[5];
        String heldItem; // shortcut to equipment[0]
        bool isValid = true;
        Array metadata;
        float Health;
        float food;
        float foodsaturation;
        public Entity(uint ida) {
            id = ida;
            heldItem = equipment[0];
        }
    }
}
