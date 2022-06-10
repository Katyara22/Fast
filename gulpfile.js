const gulp = require('gulp');
const browserSync = require('browser-sync');
const sass = require('gulp-sass')(require('sass'));
const rename = require("gulp-rename");
const autoprefix = require('gulp-autoprefixer');
const cleanCSS = require('gulp-clean-css');

// Static server
gulp.task('server', function () {
    browserSync.init({
        server: {
            baseDir: "src"
        }
    });
});

gulp.task('styles', function () {
    return gulp.src("src/assets/sass/style/*.+(scss|sass)")
        .pipe(sass({ autputStyle: 'compressed' }).on('error', sass.logError))
        .pipe(rename({
            prefix: "",
            suffix: "",
        }))
        .pipe(autoprefix({
            browsers: ['last 2 versions'],
            cascade: false
        }))
        .pipe(cleanCSS({ compatibility: 'ie8' }))
        .pipe(gulp.dest("src/assets/css"))
        .pipe(browserSync.stream());
});

gulp.task('footer', function () {
    return gulp.src("src/assets/sass/footer/*.+(scss|sass)")
        .pipe(sass({ autputStyle: 'compressed' }).on('error', sass.logError))
        .pipe(rename({
            prefix: "",
            suffix: "",
        }))
        .pipe(autoprefix({
            browsers: ['last 2 versions'],
            cascade: false
        }))
        .pipe(cleanCSS({ compatibility: 'ie8' }))
        .pipe(gulp.dest("src/assets/css"))
        .pipe(browserSync.stream());
});

gulp.task('header', function () {
    return gulp.src("src/assets/sass/header/*.+(scss|sass)")
        .pipe(sass({ autputStyle: 'compressed' }).on('error', sass.logError))
        .pipe(rename({
            prefix: "",
            suffix: "",
        }))
        .pipe(autoprefix({
            browsers: ['last 2 versions'],
            cascade: false
        }))
        .pipe(cleanCSS({ compatibility: 'ie8' }))
        .pipe(gulp.dest("src/assets/css"))
        .pipe(browserSync.stream());
});

gulp.task('admin', function () {
    return gulp.src("src/assets/sass/admin/*.+(scss|sass)")
        .pipe(sass({ autputStyle: 'compressed' }).on('error', sass.logError))
        .pipe(rename({
            prefix: "",
            suffix: "",
        }))
        .pipe(autoprefix({
            browsers: ['last 2 versions'],
            cascade: false
        }))
        .pipe(cleanCSS({ compatibility: 'ie8' }))
        .pipe(gulp.dest("src/assets/css"))
        .pipe(browserSync.stream());
});

gulp.task('watch', function () {
    gulp.watch("src/assets/sass/header/*.+(scss|sass)", gulp.parallel("styles"));
    gulp.watch("src/*.html").on("change", browserSync.reload);
})

gulp.task('default', gulp.parallel('watch', 'server', 'styles', 'header', 'footer'));