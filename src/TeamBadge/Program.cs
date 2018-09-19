using System;

namespace TeamBadge
{
    class Program
    {
        static void Main(string[] args)
        {
            var template = @"
[![](http://bcircle.hopto.org:8111/app/rest/builds/buildType:{id}_Build/statusIcon)](http://bcircle.hopto.org:8111/viewType.html?buildTypeId={id}_Build)";
            var r = template.Replace("{id}", args[0]);
            Console.WriteLine(r);
        }
    }
}
