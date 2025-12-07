using System;
using System.Dynamic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Word
{
  
    private string _text;
    private bool _active;

    public Word(string text)
    {
        _text = text;
        _active = true;
    }

    public bool IsActive()
    {
        return _active;
    }

    public string Display()
    {
        if (_active)
        {
            return _text;
        }
        else
        {
            return new string('_', _text.Length);
        }
    } 

    public void Hide()
    {
        _active = false;
    }

}  
							
	

