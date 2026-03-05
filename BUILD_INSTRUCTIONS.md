# Build and Deployment Instructions for Android and iOS

## Android  
1. **Install Android Studio**: Ensure that you have the latest version of Android Studio installed on your system.
2. **Clone the Repository**: Use the command `git clone https://github.com/Kaankarmn/Realm-Runes.git` to clone the repository to your local machine.
3. **Gradle Setup**: Open the project in Android Studio. The project will automatically sync Gradle, but you can also run `./gradlew build` in the terminal to ensure everything is set up correctly.
4. **Build the APK**: To build the APK, navigate to `Build > Build Bundle(s)/APK > Build APK(s)`. The generated APK will be located in the `app/build/outputs/apk/` directory.
5. **Deploy to Device**: Connect your Android device via USB or use an emulator. To deploy, click on `Run > Run 'app'` in Android Studio.

## iOS  
1. **Install Xcode**: Ensure you have Xcode installed on your Mac.
2. **Clone the Repository**: Use the command `git clone https://github.com/Kaankarmn/Realm-Runes.git` to clone the repository to your local machine.
3. **Open the Project**: Open the `.xcworkspace` file in Xcode.
4. **Install Dependencies**: If you are using CocoaPods, run `pod install` in the terminal to install the necessary dependencies.
5. **Build the App**: Choose your target device (simulator or physical device) and click `Product > Build` or simply use the shortcut `Command + B`.
6. **Deploy to Device**: To run the app, select `Product > Run` or use `Command + R`. If you’re deploying to a physical device, ensure that it is connected and trusted by your Mac.

---  
These instructions guide through the basic build and deployment process for both Android and iOS platforms. Ensure that you have the necessary SDKs and dependencies installed.