build:
	@dotnet run --project ./src/Necodark 

clean:
	@rm -rf ./build

.PHONY: build clean