using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardCommand : Command
{
    public override void Execute(Rigidbody rb)
    {
        // Add an impulse that moves the rigidbody forward
        //rb.AddForce(_Speed*rb.transform.forward, ForceMode.VelocityChange);
        rb.transform.position += rb.transform.forward;

    }

    public override void Undo(Rigidbody rb)
    {
        rb.transform.position -= rb.transform.forward;
    }
}
