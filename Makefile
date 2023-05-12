.PHONY: build
build:
	@dotnet run --project ./src/Necodark
	@make vscode-package

.PHONY: vscode-package
vscode-package:
	@ln -sf ../../LICENSE ./build/vscode
	@ln -sf ../../README.md ./build/vscode
	@cd build/vscode && vsce package

.PHONY: clean
clean:
	@rm -rf ./build
