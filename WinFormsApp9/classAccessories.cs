using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accessibility;

namespace WinFormsApp9
{
    //public class CPU : Accessories
    //{
    //    public CPU(string type, string name, string description, int price, 
    //        string socket, int cores, int streams, double frequency) : base(type, name, description, price)
    //    {
    //        _socket = socket;
    //        _cores = cores;
    //        _streams = streams;
    //        _frequency = frequency;
    //    }

    //    private string _socket;

    //    private int _cores;
    //    private int _streams;

    //    private double _frequency;

    //    public string Socket { get { return _socket; } }

    //    public int Cores { get { return _cores; } }
    //    public int Streams { get { return _streams; } }

    //    public double Frequency { get { return _frequency; } }
    //}

    //public class RAM : Accessories
    //{
    //    public RAM(string type, string name, string description, int price, 
    //        int volumeMemory, string TypeMemory, double frequency, int NumberOfModules) : base(type, name, description, price)
    //    {
    //        _volumeMemory = volumeMemory;
    //        _typeMemory = TypeMemory;
    //        _frequency = frequency;
    //        _numberOfModules = NumberOfModules;
    //    }

    //    private int _volumeMemory;
    //    private int _numberOfModules;

    //    private double _frequency;

    //    private string _typeMemory;

    //    public int VolumeMemory { get { return _volumeMemory; } }
    //    public int NumberOfModules { get { return _numberOfModules; } }

    //    public double Frequency { get { return _frequency; } }

    //    public string TypeMemory { get { return _typeMemory; } }

    //}

    //public class PowerSupply : Accessories
    //{
    //    public PowerSupply(string type, string name, string description, int price, 
    //        int powerOfTheUnit, string FormFactor) : base(type, name, description, price)
    //    {
    //        _powerOfTheUnit = powerOfTheUnit;
    //        _formFactor = FormFactor;
    //    }

    //    private int _powerOfTheUnit;

    //    private string _formFactor;

    //    public int PowerOfTheUnit { get { return _powerOfTheUnit; } }

    //    public string FormFactor { get { return _formFactor; } }
    //}

    //public class SSD : Accessories
    //{
    //    public SSD(string type, string name, string description, int price,
    //        int volumeMemory, string interfaceConnecting) : base(type, name, description, price)
    //    {
    //        _volumeMemory = volumeMemory;
    //        _interfaceConnecting = interfaceConnecting;
    //    }

    //    private int _volumeMemory;

    //    private string _interfaceConnecting;

    //    public int VolumeMemory { get { return _volumeMemory; } }
    //    public string InterfaceConnecting { get {  return _interfaceConnecting; } }
    //}

    //public class VideoCard : Accessories
    //{
    //    public VideoCard(string type, string name, string description, int price, 
    //        int volumeMemory, string typeMemory, string interfaceConnecting) : base(type, name, description, price)
    //    {
    //        _volumeMemory = volumeMemory;
    //        _typeMemory = typeMemory;
    //        _interfaceConnecting = interfaceConnecting;
    //    }

    //    private int _volumeMemory;

    //    private string _typeMemory;
    //    private string _interfaceConnecting;

    //    public int VolumeMemory { get { return _volumeMemory; } }
        
    //    public string TypeMemory { get { return _typeMemory; } }
    //    public string InterfaceConnecting { get { return _interfaceConnecting; } }

    //}

    public class Accessories
    {
        public Accessories(string type, string name, string description, int price) 
        {
            _type = type;
            _name = name;
            _description = description;
            _price = price;
        }

        private string _type;
        private string _name;
        private string _description;

        private int _price;

        public string Type { get { return _type; } }
        public string Name { get { return _name; } }
        public string Description { get { return _description; } }

        public int Price { get { return _price; } }
    }
}
