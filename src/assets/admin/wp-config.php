<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the installation.
 * You don't have to use the web site, you can copy this file to "wp-config.php"
 * and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * Database settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://wordpress.org/support/article/editing-wp-config-php/
 *
 * @package WordPress
 */

// ** Database settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define( 'DB_NAME', 'lesson' );

/** Database username */
define( 'DB_USER', 'admin' );

/** Database password */
define( 'DB_PASSWORD', 'admin' );

/** Database hostname */
define( 'DB_HOST', 'localhost' );

/** Database charset to use in creating database tables. */
define( 'DB_CHARSET', 'utf8mb4' );

/** The database collate type. Don't change this if in doubt. */
define( 'DB_COLLATE', '' );

/**#@+
 * Authentication unique keys and salts.
 *
 * Change these to different unique phrases! You can generate these using
 * the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}.
 *
 * You can change these at any point in time to invalidate all existing cookies.
 * This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define( 'AUTH_KEY',         'jNjvj,_> NLXj=ZTG3]PgS`ogO?:rwY<vrGOqY5YS2~tK`o5PcdCMzz23Tk:C]9r' );
define( 'SECURE_AUTH_KEY',  'E<tU;<l+Wsa_!754>.1bR4;)Oo;u+Lmg+,/y-%c_-M`YlK/P$?dpxJJ$Q<2B0:b(' );
define( 'LOGGED_IN_KEY',    ')XJS]!!b6r/v@9+iWBVzF3IRpIot!$I)7O,61I4?K7}G^Il<C;TRx[6<Y]((mOd/' );
define( 'NONCE_KEY',        'j3$STTH*oS!`oSpSnh2Jb ]|=yqy[9jkUf`LMRnuj$7VSf7s$)S>:$BfNI]=9TxL' );
define( 'AUTH_SALT',        '<uZf}OQdKB q>u@n ;Q?@s7ZQJWAst_D[*f{;>J7geK>24fq.,J>>KlmNs%*m_YU' );
define( 'SECURE_AUTH_SALT', 'w?71dfj,sW}%T!=+@s`&?|Xgx&cJnv1?WLDL`JU&^5R>5xONHK_HEt(RL9!7i]H?' );
define( 'LOGGED_IN_SALT',   'n9K9+[Ep`SE([=h=m0NG=naTmutec`0q/N~8]m$%v*D,4u9i<f*g P!4.g+J=|;n' );
define( 'NONCE_SALT',       'u!/}[>;R63u0#3SH6OU@lk^$suWE;^bs+lxR2^YEBU2r<;Bq~T{n4B.UjP:*]5-f' );

/**#@-*/

/**
 * WordPress database table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the documentation.
 *
 * @link https://wordpress.org/support/article/debugging-in-wordpress/
 */
define( 'WP_DEBUG', false );

/* Add any custom values between this line and the "stop editing" line. */



/* That's all, stop editing! Happy publishing. */

/** Absolute path to the WordPress directory. */
if ( ! defined( 'ABSPATH' ) ) {
	define( 'ABSPATH', __DIR__ . '/' );
}

/** Sets up WordPress vars and included files. */
require_once ABSPATH . 'wp-settings.php';
