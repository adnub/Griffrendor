griffrendor.exe:
	csc -target:winexe -r:System.Drawing.dll -r:System.Windows.Forms.dll griffrendor.cs
clean:
	rm griffrendor.exe
