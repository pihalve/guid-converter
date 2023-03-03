# GUID Converter
Windows tray app used for converting "normal" GUIDs to and from MongoDB GUIDs

![image](https://user-images.githubusercontent.com/1714173/222810855-c7d9c35a-f40f-4374-be23-6635ce1e172e.png)

The reason for implementing this app was to make it easier to work with GUIDs with MongoDB clients, such as MongoDB Compass. When querying by ID of type GUID, you need to use the "BinData" format, e.g. `{_id: BinData(3, 'pOysdl8TVUKi73osr65lNg==')}`

The app will convert between "normal" GUID and MongoDB GUID. If you copy either a "normal" GUID value or a MongoDB GUID value to clipboard and activate the app, then it will immediately do conversion and show a number of output representations.

## Build
To build into a single file (but still dependent on .Net 6 being installed) run this from root of solution:

```
dotnet publish -c Release -r win-x64
```

This will build an executable into `bin\Release\net6.0-windows\win-x64\publish`
