/// <binding BeforeBuild='less' />
var gulp = require("gulp"),
    fs = require("fs"),
    less = require("gulp-less");

var libs = './wwwroot/libs/';

gulp.task('default', function () {
    // place code for your default task here
});

gulp.task("less", function () {
    return gulp.src('wwwroot/css/main.less')
        .pipe(less())
        .pipe(gulp.dest('wwwroot/css'));
});

gulp.task('restore:jquery', function () {
    gulp.src([
        'node_modules/jquery/dist/*.js'
    ]).pipe(gulp.dest(libs + 'jquery'));
});

gulp.task('restore:popper', function () {
    gulp.src([
        'node_modules/popper.js/dist/umd/*.js'
    ]).pipe(gulp.dest(libs + 'popper'));
});

gulp.task('restore:bootstrap', function () {
    gulp.src([
        'node_modules/bootstrap/dist/**/*.*'
    ]).pipe(gulp.dest(libs + 'bootstrap'));
});

gulp.task('restore:angular', function () {
    gulp.src([
        'node_modules/angular/**/*.js'
    ]).pipe(gulp.dest(libs + 'angular'));
});

gulp.task('restore:angular-animate', function () {
    gulp.src([
        'node_modules/angular-animate/*.js'
    ]).pipe(gulp.dest(libs + 'angular-animate'));
});

gulp.task('restore:angular-sanitize', function () {
    gulp.src([
        'node_modules/angular-sanitize/*.js'
    ]).pipe(gulp.dest(libs + 'angular-sanitize'));
});

gulp.task('restore:lodash', function () {
    gulp.src([
        'node_modules/lodash/lodash.js',
        'node_modules/lodash/lodash.min.js'
    ]).pipe(gulp.dest(libs + 'lodash'));
});

gulp.task('restore:sprintf', function () {
    gulp.src([
        'node_modules/sprintf-js/dist/*.js',
        'node_modules/sprintf-js/src/*.js'
    ]).pipe(gulp.dest(libs + 'sprintf'));
});

gulp.task('restore', [
    'restore:jquery',
    'restore:popper',
    'restore:bootstrap',
    'restore:angular',
    'restore:angular-animate',
    'restore:angular-sanitize',
    'restore:lodash',
    'restore:sprintf'
]);