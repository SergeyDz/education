// Generated on 2014-09-26 using generator-angular 0.9.8
'use strict';

// # Globbing
// for performance reasons we're only matching one level down:
// 'test/spec/{,*/}*.js'
// use this if you want to recursively match all subfolders:
// 'test/spec/**/*.js'

module.exports = function (grunt) {

    // Configurable paths for the application
    var appConfig = {
        app: 'app',
        dist: 'dist'
    };

    grunt.loadNpmTasks('grunt-wiredep');
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-uglify');

    grunt.initConfig({
        // Project settings
        yeoman: appConfig,

        concat: {
            options: {
                separator: ''
            },
            dist: {
                src: [
                    '<%= yeoman.app %>/src/*.js',
                ],
                dest: '<%= yeoman.dist %>/angular-sample.js'
            }
        },
        uglify: {
            dist: {
                files: {
                    '<%= yeoman.dist %>/angular-sample.min.js': ['<%= yeoman.dist %>/angular-sample.js']
                }
            }
        }
    });

    grunt.registerTask('default', ['concat', 'uglify']);
    grunt.registerTask('build', ['concat', 'uglify']);
};
