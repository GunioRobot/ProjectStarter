using System;
using ProjectStarter;
using Xunit;

namespace ProjectStarter_tests {

    public class when_using_a_json_config_file {

        private MockFileSystem _mockFileSystem;
        private ArgParser _parser;

        private const string DefaultConfigFileName = "default.json";

        public when_using_a_json_config_file() {
            _mockFileSystem = new MockFileSystem();
            _parser = new ArgParser(null, _mockFileSystem);
        }

        [Fact]
        public void should_read_the_default_config() {
            Assert.Contains(DefaultConfigFileName ,_mockFileSystem.FilesRead );
        }

        [Fact]
        public void should_deserialize_the_config_file() {
            Assert.NotNull(_parser.Config);
        }

        [Fact]
        public void config_file_should_be_the_proper_type() {
            Assert.IsType(typeof(ProjectStarterConfig), _parser.Config);
        }
    }
}