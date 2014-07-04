debug:
	cd Defs && $(MAKE)
	cd Frameworks && $(MAKE)

release:
	cd Defs && $(MAKE) release
	cd Frameworks && $(MAKE) release
