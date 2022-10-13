// See https://aka.ms/new-console-template for more information
using VersionCheckerSample.Extensions;
using VersionCheckerSample.Models;

Console.WriteLine("Version Check Sample\n\n");


var testUiVersion1 = new VersionModel
{
    Major = 0,
    Minor = 2,
    Patch = 3,
    Build = 0
};

var testApiVersion1 = new VersionModel
{
    Major = 1,
    Minor = 0,
    Patch = 3,
    Build = 0
};

var testUiVersion2 = new VersionModel
{
    Major = 0,
    Minor = 1,
    Patch = 4,
    Build = 0
};

var testApiVersion2 = new VersionModel
{
    Major = 1,
    Minor = 7,
    Patch = 0,
    Build = 0
};

var testUiVersion3 = new VersionModel
{
    Major = 0,
    Minor = 2,
    Patch = 1,
    Build = 0
};

var testApiVersion3 = new VersionModel
{
    Major = 2,
    Minor = 6,
    Patch = 0,
    Build = 0
};

Console.WriteLine($"Is UI{testUiVersion1} compatible with Api{testApiVersion1}? {testUiVersion1.IsCompatible(testApiVersion1)}");
Console.WriteLine($"Is UI{testUiVersion2} compatible with Api{testApiVersion2}? {testUiVersion1.IsCompatible(testApiVersion2)}");
Console.WriteLine($"Is UI{testUiVersion3} compatible with Api{testApiVersion3}? {testUiVersion1.IsCompatible(testApiVersion3)}");


Console.ReadKey();
