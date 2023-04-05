XBUILD=/Applications/Xcode_14.2.0.app/Contents/Developer/usr/bin/xcodebuild
ROOT=$(PWD)
PROJECT_ROOT=$(ROOT)/../external/DrasticForbiddenControls
PROJECT_IOS=$(PROJECT_ROOT)/DrasticForbiddenControls.xcodeproj
BUILD_ROOT=$(PROJECT_ROOT)/build
PROJECTNAME=DrasticForbiddenControls
IOS_FRAMEWORK_PATH=Products/Library/Frameworks/DrasticForbiddenControls.framework
FRAMEWORKS=$(ROOT)/Frameworks
TARGET_IOS="DrasticForbiddenControls"
IOS_SDK=iphoneos16.2
BINDING_OUTPUT=$(ROOT)/../bindings
HEADERS=$(FRAMEWORKS)/$(PROJECTNAME).xcframework/ios-arm64_x86_64-maccatalyst/DrasticForbiddenControls.framework/Headers

build: maccatalyst xcframework

maccatalyst:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT_IOS) -scheme $(TARGET_IOS) -destination "generic/platform=macOS,variant=Mac Catalyst,name=Any Mac" -archivePath $(BUILD_ROOT)/catalyst.xcarchive SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

xcframework:
	rm -rf $(BUILD_ROOT)/$(PROJECTNAME).xcframework
	$(XBUILD) -create-xcframework -framework $(BUILD_ROOT)/catalyst.xcarchive/$(IOS_FRAMEWORK_PATH) -output $(BUILD_ROOT)/$(PROJECTNAME).xcframework
	rm -rf $(FRAMEWORKS)
	mkdir -p $(FRAMEWORKS)
	cp -R $(BUILD_ROOT)/ $(FRAMEWORKS)

pack: 
	dotnet pack $(ROOT)/Drastic.ForbiddenControls/Drastic.ForbiddenControls.csproj --configuration Release --output $(ROOT)/../nuget

sharpie:
	sharpie bind --sdk=$(IOS_SDK) --output="$(BINDING_OUTPUT)" --namespace="DrasticForbiddenControls" --scope="$(HEADERS)" $(HEADERS)/*.h