# WindowFormsApp3
Dit is qua powershell functionaliteit de aanpak om mee verder te gaan. Het is resulaat van zoeken naar een mogelijkheid om een elevated script uit te voeren en de output daarvan in een Winformapplicatie te krijgen... dat was best wel even lastig.

1. WinForms .NET app.
2. Creëert een "powershell.exe" instantie in Windows 11 process via Process.Start()
3. Een Process.ProcessStartInfo object wordt gebruikt voor de configuratie.
4. Er wordt een elevated process opgestart dus (dus powershell met Administrator rights)
5. De ouput van de powershell instantie wordt omgeleid (ProcessStartInfo().RedirectStandardOutput = true en  ProcessStartInfo(). RedirectStandardError = true)
6. De printout van het script worden asynchroon verwerkt via eventhandling.
7. De output wordt afgedruk in een richtextbox.
