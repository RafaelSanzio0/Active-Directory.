using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace teste1.Class
{
    public class MyTools
    {
        public static bool verificaObj(string caminhoObj)
        {
            DirectoryEntry directoryEntry = new DirectoryEntry("LDAP://192.168.92.200/" + caminhoObj, "contoso\\administrator", "Br@sil01");
            //directoryEntry.Username = "username";
            //directoryEntry.Password = "password";

            bool exists = false;
            // Validate with Guid
            try
            {
                var tmp = directoryEntry.Guid;
                exists = true;

            }
            catch (COMException)
            {
                exists = false;
            }
            return exists;

        }

        public static void DirectoryEntryConfigurationSettings(string domainADsPath)
        {
            // Bind to current domain

            DirectoryEntry entry = new DirectoryEntry("LDAP://192.168.92.200/" + domainADsPath, "contoso\\administrator", "Br@sil01");
            DirectoryEntryConfiguration entryConfiguration = entry.Options;

            Console.WriteLine("Server: " + entryConfiguration.GetCurrentServerName());
            Console.WriteLine("Page Size: " + entryConfiguration.PageSize.ToString());
            Console.WriteLine("Password Encoding: " +
                entryConfiguration.PasswordEncoding.ToString());
            Console.WriteLine("Password Port: " +
                entryConfiguration.PasswordPort.ToString());
            Console.WriteLine("Referral: " + entryConfiguration.Referral.ToString());
            Console.WriteLine("Security Masks: " +
                entryConfiguration.SecurityMasks.ToString());
            Console.WriteLine("Is Mutually Authenticated: " +
                entryConfiguration.IsMutuallyAuthenticated().ToString());
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

