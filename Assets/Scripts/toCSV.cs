using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.IO.Ports;
using System.Text;
using UnityEngine.TextCore.Text;


public class toCSV : MonoBehaviour
{
    // Start is called before the first frame update
    private SerialPort stream = new SerialPort("COM3", 9600);
    public string receivedData;
    private StringBuilder sb = new StringBuilder("Time, Value");
    private float tss;
    private string filename = "";
    void Start()
    {
        stream.Open();
        stream.ReadTimeout = 500;
        filename = Application.dataPath + "/test.csv";
        if (File.Exists(filename))
        {
            File.Delete(filename);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //print(stream.ReadLine());
        receivedData = stream.ReadLine();
        tss = Time.realtimeSinceStartup;
        //sb.Append(tss, receivedData);
        sb.Append('\n').Append(tss).Append(',').Append(receivedData);
        print(sb.ToString());
    }

    public void sbToCSV()
    {
        TextWriter tw = new StreamWriter(filename, true);
        tw.WriteLine("Time, Value");
        //for (int i = 0; i < sb.Length; i++)
        //{
        //    tw.WriteLine(sb);
       // }
       tw.WriteLine(sb);
       tw.Close();
    }
    private void OnApplicationQuit()
    {
        sbToCSV();
    }
}
