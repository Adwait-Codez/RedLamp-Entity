using System;
using System.Collections.Generic;
using Godot;

namespace RedLamp_Entity
{
    public class Entity
    {
        int id;
        String type;
        Vector3 position;
        Vector3 velocity;
        float yaw;
        float pitch;
        bool onGround=true;
        float height;
        float width;
        Dictionary<int, String> effects;
        // 0 = held item, 1-4 = armor slot
        String[] equipment = new String[5];
        String heldItem; // shortcut to equipment[0]
        bool isValid = true;
        Array metadata;
    }
}
