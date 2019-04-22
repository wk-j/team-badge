using System;

namespace TeamBadge {
    class Program {
        static void Main(string[] args) {
            var template = @"
[![](http://bcircle.hopto.org:8111/app/rest/builds/buildType:{id}_Build/statusIcon)](http://bcircle.hopto.org:8111/viewType.html?buildTypeId={id}_Build)";

            var r = template
                .Trim()
                .Replace("{id}", args[0])
                .Replace("http://bcircle.hopto.org:8111", "http://183.88.235.202:8111");

            Console.WriteLine(r);
        }
    }
}