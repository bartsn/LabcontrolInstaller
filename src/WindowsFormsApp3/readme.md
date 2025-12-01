# WindowFormsApp3
1. WinForms .NET app.
2. Creëert een "powershell.exe" instantie in Windows 11 process via Process.Start()
3. Een Process.ProcessStartInfo object wordt gebruikt voor de configuratie.
4. Er wordt een elevated process opgestart dus (dus powershell met Administrator rights)
5. De ouput van de powershell instantie wordt omgeleid (ProcessStartInfo().RedirectStandardOutput = true en  ProcessStartInfo(). RedirectStandardError = true)
6. De printout van het script worden asynchroon verwerkt via eventhandling.
7. De output wordt afgedruk in een richtextbox.
